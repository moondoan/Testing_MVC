using Abp.Web.Mvc.Views;

namespace Sp.AvSec.Mvc.Views
{
    public abstract class AvSecWebViewPageBase : AvSecWebViewPageBase<dynamic>
    {

    }

    public abstract class AvSecWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AvSecWebViewPageBase()
        {
            LocalizationSourceName = AvSecConsts.LocalizationSourceName;
        }
    }
}