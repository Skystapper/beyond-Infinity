public abstract class NsfwImageGenCommand : ImageGenCommand
{
    protected override int GetAdditionalPrice() => 12;

    protected override bool IsSfw() => false;
    protected override string GetEngineName() => "nai-diffusion";
}