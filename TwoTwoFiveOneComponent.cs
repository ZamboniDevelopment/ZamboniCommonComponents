using BlazeCommon;
using ZamboniCommonComponents.Bases;

namespace ZamboniCommonComponents;

public class TwoTwoFiveOneComponent : TwoTwoFiveOneComponentBase.Server
{
    public override Task<NullStruct> OneOneTwoAsync(NullStruct request, BlazeRpcContext context)
    {
        return Task.FromResult(new NullStruct());
    }
}