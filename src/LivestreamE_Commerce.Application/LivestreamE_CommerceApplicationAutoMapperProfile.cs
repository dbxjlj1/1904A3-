using AutoMapper;
using LivestreamE_Commerce.Dto.GoodsDto;
using LivestreamE_Commerce.Dto.RBACDto;
using LivestreamE_Commerce.Model.Goods;
using LivestreamE_Commerce.Model.RBAC;

namespace LivestreamE_Commerce
{
    public class LivestreamE_CommerceApplicationAutoMapperProfile : Profile
    {
        public LivestreamE_CommerceApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            #region 购物车实体映射

            CreateMap<GoodsModel, GoodsDto>();
            CreateMap<GoodsImgModel, GoodsImgDto>();
            CreateMap<GoodsSpecificationModel, GoodsSpecificationDto>();
            CreateMap<GoodsTypeModel, GoodsTypeDto>();
            CreateMap<ImgModel, ImgDto>();
            CreateMap<SpecificationModel, SpecificationDto>();
            CreateMap<IndentDetailModel, IndentDetailDto>();
            CreateMap<IndentModel, IndentDto>();
            CreateMap<SiteModel, SiteDto>();
            CreateMap<UserImgModel, UserImgDto>();

            #endregion
            #region RBAC实体映射
            CreateMap<LogModel, LogDto>();
            CreateMap<MenuModel, MenuDto>();
            CreateMap<OrganizationModel, OrganizationDto>();
            CreateMap<RoleModel, RoleDto>();
            CreateMap<RoleMenuModel, RoleMenuDto>();
            CreateMap<UserModel, UserDto>();
            CreateMap<UserRoleModel, UserRoleDto>();

            #endregion

        }
    }
}
