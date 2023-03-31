public class Pole {
    public bool Zajete=false;
    public string Znak="-";
    public string oznaczenie="k";
    public void uzupelnij_kolko (Kolko symbol) {
        Znak=symbol.znak;
        Zajete=true;
    }
    public void uzupelnij_krzyzyk(Krzyzyk symbol) {
        Znak=symbol.znak;
        Zajete=true;
    }
}