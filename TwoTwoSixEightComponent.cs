using BlazeCommon;
using ZamboniCommonComponents.Bases;

namespace ZamboniCommonComponents;

public class TwoTwoSixEightComponent : TwoTwoSixEightComponentBase.Server
{
    public override Task<NullStruct> ThreeAsync(NullStruct request, BlazeRpcContext context)
    {
        return Task.FromResult(new NullStruct());
    }
}