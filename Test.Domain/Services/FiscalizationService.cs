using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{

    public class FiscalizationService : IFiscalizationService
    {
        public readonly IHandleIdDeviceService Handheld;

        public FiscalizationService(IHandleIdDeviceService handheld)
        {
            Handheld = handheld;
        }

        // Iniciar Fiscalizacion
        public void StartFiscalization(Fiscalization fiscalization)
        {
            Console.WriteLine("Starting fiscalization...");

            //Efectuar Revision Picking
            ReviewPicking(fiscalization.dispatchDocuments);

            //Cantidad de bultos cuadrada
            bool isCountCorrect = Handheld.ValidatePackageCount(fiscalization.packages.Count, fiscalization.dispatchDocuments.ExpectedPackageCount);

            if (isCountCorrect)
            {
                //Confirmar cuadratura de bultos
                ConfirmPackageCount();
            }
            else
            {
                // manejo de errores de cuadratura de bultos
                HandleDiscrepancies(fiscalization.packages,fiscalization.dispatchDocuments);
            }
        }

        private void ReviewPicking(DispatchDocuments dispatchDocuments)
        {
            Console.WriteLine("Reviewing picking documents and delivery schedule.");
            dispatchDocuments.ReviewDocuments();
        }

        private void ConfirmPackageCount()
        {
            Console.WriteLine("Confirming that package count is correct.");
            Handheld.ConfirmPackageQuantity();
        }

        private void HandleDiscrepancies(List<Package> packages, DispatchDocuments dispatchDocuments)
        {
            int difference = packages.Count - dispatchDocuments.ExpectedPackageCount;

            if (difference > 0)
            {
                //Retirar bultos no correspondientes
                HandleExtraPackages(packages, difference);
            }
            else if (difference < 0)
            {
                //Efectuar busqueda de bulto faltante
                HandleMissingPackages(packages, Math.Abs(difference));
            }

            // Confirmar cuadratura de bultos (despues de ver los faltantes o los sobrantes)
            bool revalidated = Handheld.ValidatePackageCount(packages.Count, dispatchDocuments.ExpectedPackageCount);

            if (revalidated)
            {
                //confirmar
                ConfirmPackageCount();
            }
            else
            {
                Console.WriteLine("Discrepancies not resolved.");
                //evidenciar descuadre
                RecordDiscrepancy();
            }
        }

        private void HandleExtraPackages(List<Package> packages, int excessCount)
        {
            Console.WriteLine($"Handling extra packages. Removing {excessCount} extra packages.");
            Handheld.RemoveExtraPackages(packages, excessCount);
        }

        private void HandleMissingPackages(List<Package> packages, int missingCount)
        {
            Console.WriteLine($"Searching for {missingCount} missing packages.");
            Handheld.SearchForMissingPackages(packages, missingCount);
        }

        private void RecordDiscrepancy()
        {
            Console.WriteLine("Recording discrepancy due to unresolved mismatch.");
            Handheld.RecordDiscrepancy();
        }
    }

}
