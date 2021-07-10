using Ado.Library;
using Ado.Library.Specifics;
using Ado.User.Abstracts;
using Ado.User.Specifics;
using DBAccess.Ado.Repositories.Concrect;
using Models.Repositories.Abstract;
using Ninject.Modules;
using Business.BookStoreServices.Abstracts;
using Business.BookStoreServices.Specifics;
using Businness.UserServices.Abstracts;
using Businness.UserServices.Specifics;
using Core.Logger.Abstracts;
using Logger.Specifics;
using Business.FileServices.Abstracts;
using Business.FileServices.Specifics;
using Core.FileService.Abstracts;
using Core.FileService.Specifics;

namespace Business.DependencyInjection
{
    public class ModuleNinject : NinjectModule
    {
        public override void Load()
        {

            // Autor

            Bind<IAutorRepository>().To<AutorRepository>().InSingletonScope();
            Bind<IAutorService>().To<AutorService>().InSingletonScope();

            // BookEditorial 

            Bind<IBookEditorialRepository>().To<BookEditorialRepository>().InSingletonScope();
            Bind<IBookEditorialService>().To<BookEditorialService>().InSingletonScope();

            // Book

            Bind<IBookRepository>().To<BookRepository>().InSingletonScope();
            Bind<IBookService>().To<BookService>().InSingletonScope();

            // BookStore

            Bind<IBookStoreRepository>().To<BookStoreRepository>().InSingletonScope();
            Bind<IBookStoreService>().To<BookStoreService>().InSingletonScope();

            // BookType

            Bind<IBookTypeRepository>().To<BookTypeRepository>().InSingletonScope();
            Bind<IBookTypeService>().To<BookTypeService>().InSingletonScope();

            // Coupon 

            Bind<ICouponRepository>().To<CouponRepository>().InSingletonScope();
            Bind<ICouponService>().To<CouponService>().InSingletonScope();

            // Direction

            Bind<IDirectionRepository>().To<DirectionRepository>().InSingletonScope();
            Bind<IDirectionService>().To<DirectionService>().InSingletonScope();

            // Discount 

            Bind<IDiscountRepository>().To<DiscountRepository>().InSingletonScope();
            Bind<IDiscountService>().To<DiscountService>().InSingletonScope();

 

            // Edition

            Bind<IEditionRepository>().To<EditionRepository>().InSingletonScope();
            Bind<IEditionService>().To<EditionService>().InSingletonScope();

            // Editorial

            Bind<IEditorialRepository>().To<EditorialRepository>().InSingletonScope();
            Bind<IEditorialService>().To<EditorialService>().InSingletonScope();

            // Employee 

            Bind<IEmployeeRepository>().To<EmployeeRepository>().InSingletonScope();
            Bind<IEmployeeService>().To<EmployeeService>().InSingletonScope();

            // Gender 

            Bind<IGenderRepository>().To<GenderRepository>().InSingletonScope();
            Bind<IGenderService>().To<GenderService>().InSingletonScope();

          

            // Occupation

            Bind<IOccupationRepository>().To<OccupationRepository>().InSingletonScope();
            Bind<IOccupationService>().To<OccupationService>().InSingletonScope();

            // OrderLine

            Bind<IOrderLineRepository>().To<OrderLineRepository>().InSingletonScope();
            Bind<IOrderLineService>().To<OrderLineService>().InSingletonScope();

            // Order

            Bind<IOrderRepository>().To<OrderRepository>().InSingletonScope();
            Bind<IOrderService>().To<OrderService>().InSingletonScope();

            // PaymentBonus

            Bind<IPaymentBonusRepository>().To<PaymentBonusRepository>().InSingletonScope();
            Bind<IPaymentBonusService>().To<PaymentBonusService>().InSingletonScope();

            // PayRoll

            Bind<IPayRollRepository>().To<PayRollRepository>().InSingletonScope();
            Bind<IPayRollService>().To<PayRollService>().InSingletonScope();

            // Permit

            Bind<IPermitRepository>().To<PermitRepository>().InSingletonScope();
            Bind<IPermitService>().To<PermitService>().InSingletonScope();

            // Person

            Bind<IPersonRepository>().To<PersonRepository>().InSingletonScope();
            Bind<IPersonService>().To<PersonService>().InSingletonScope();

            // Provider 

            Bind<IProviderRepository>().To<ProviderRepository>().InSingletonScope();
            Bind<IProviderService>().To<ProviderService>().InSingletonScope();

            // PurchaseLine

            Bind<IPurchaseLineRepository>().To<PurchaseLineRepository>().InSingletonScope();
            Bind<IPurchaseLineService>().To<PurchaseLineService>().InSingletonScope();

            // Purchase

            Bind<IPurchaseRepository>().To<PurchaseRepository>().InSingletonScope();
            Bind<IPurchaseService>().To<PurchaseService>().InSingletonScope();

            // ReceptionLine

            Bind<IReceptionLineRepository>().To<ReceptionLineRepository>().InSingletonScope();
            Bind<IReceptionLineService>().To<ReceptionLineService>().InSingletonScope();

            // Reception

            Bind<IReceptionRepository>().To<ReceptionRepository>().InSingletonScope();
            Bind<IReceptionService>().To<ReceptionService>().InSingletonScope();

            // RegisterLine

            Bind<IRegisterLineRepository>().To<RegisterLineRepository>().InSingletonScope();
            Bind<IRegisterLineService>().To<RegisterLineService>().InSingletonScope();

            // Register

            Bind<IRegisterRepository>().To<RegisterRepository>().InSingletonScope();
            Bind<IRegisterService>().To<RegisterService>().InSingletonScope();

            // ReservationOnline

            Bind<IReservationOnlineRepository>().To<ReservationOnlineRepository>().InSingletonScope();
            Bind<IReservationOnlineService>().To<ReservationOnlineService>().InSingletonScope();

            // Reservation

            Bind<IReservationRepository>().To<ReservationRepository>().InSingletonScope();
            Bind<IReservationService>().To<ReservationService>().InSingletonScope();

            // ReservationStore

            Bind<IReservationStoreRepository>().To<ReservationStoreRepository>().InSingletonScope();
            Bind<IReservationStoreService>().To<ReservationStoreService>().InSingletonScope();

            // ReturnSale

            Bind<IReturnSaleRepository>().To<ReturnSaleRepository>().InSingletonScope();
            Bind<IReturnSaleService>().To<ReturnSaleService>().InSingletonScope();

            // Rol

            Bind<IRolRepository>().To<RolRepository>().InSingletonScope();
            Bind<IRolService>().To<RolService>().InSingletonScope();

            // SaleLine

            Bind<ISaleLineRepository>().To<SaleLineRepository>().InSingletonScope();
            Bind<ISaleLineService>().To<SaleLineService>().InSingletonScope();

            // Sale

            Bind<ISaleRepository>().To<SaleRepository>().InSingletonScope();
            Bind<ISaleService>().To<SaleService>().InSingletonScope();

            // ScheduleLine

            Bind<IScheduleLineRepository>().To<ScheduleLineRepository>().InSingletonScope();
            Bind<IScheduleLineService>().To<ScheduleLineService>().InSingletonScope();

            // Schedule

            Bind<IScheduleRepository>().To<ScheduleRepository>().InSingletonScope();
            Bind<IScheduleService>().To<ScheduleService>().InSingletonScope();

            // ShippingLine

            Bind<IShippingLineRepository>().To<ShippingLineRepository>().InSingletonScope();
            Bind<IShippingLineService>().To<ShippingLineService>().InSingletonScope();

            // Shipping

            Bind<IShippingRepository>().To<ShippingRepository>().InSingletonScope();
            Bind<IShippingService>().To<ShippingService>().InSingletonScope();

            // Socie

            Bind<ISocieRepository>().To<SocieRepository>().InSingletonScope();
            Bind<ISocieService>().To<SocieService>().InSingletonScope();

            // Store

            Bind<IStoreRepository>().To<StoreRepository>().InSingletonScope();
            Bind<IStoreService>().To<StoreService>().InSingletonScope();

            // StoreSale

            Bind<IStoreSaleRepository>().To<StoreSaleRepository>().InSingletonScope();
            Bind<IStoreSaleService>().To<StoreSaleService>().InSingletonScope();

            // Taxes

            Bind<ITaxesRepository>().To<TaxesRepository>().InSingletonScope();
            Bind<ITaxesService>().To<TaxesService>().InSingletonScope();

            // WareHouseBook

            Bind<IWareHouseBookRepository>().To<WareHouseBookRepository>().InSingletonScope();
            Bind<IWareHouseBookService>().To<WareHouseBookService>().InSingletonScope();

            // WareHouse

            Bind<IWareHouseRepository>().To<WareHouseRepository>().InSingletonScope();
            Bind<IWareHouseService>().To<WareHouseService>().InSingletonScope();

            // User 

            Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
            Bind<IUserService>().To<UserService>().InSingletonScope();


            //

            Bind<ILogService>().To<FileSerilogService>().InSingletonScope();


            // FileService

            Bind<IFileServices>().To<FileServiceBase>().InSingletonScope();
            Bind<IWebFileService>().To<WebFileService>().InSingletonScope();


        }

    }
}


