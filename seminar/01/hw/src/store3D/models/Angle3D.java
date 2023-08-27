package store3D.models;

public class Angle3D {
    private double alpha, betta, gamma;

    public Angle3D(double alpha, double betta, double gamma) {
        this.alpha = alpha;
        this.betta = betta;
        this.gamma = gamma;
    }

    public double getAlpha() {
        return alpha;
    }

    public void setAlpha(double alpha) {
        this.alpha = alpha;
    }

    public double getBetta() {
        return betta;
    }

    public void setBetta(double betta) {
        this.betta = betta;
    }

    public double getGamma() {
        return gamma;
    }

    public void setGamma(double gamma) {
        this.gamma = gamma;
    }
}
