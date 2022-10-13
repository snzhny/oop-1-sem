namespace laba_6;

partial class CricketBall : Ball
{
    public CricketBall(){ inventory_name = "Cricket Ball"; }
    public override string ToString()
    {
        return $"It's a {GetType()} name - {this.inventory_name}";
    }   
}