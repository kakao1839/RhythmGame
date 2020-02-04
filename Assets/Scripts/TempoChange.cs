/*
 * テンポ変化を表現するクラス
 */
public class TempoChange
{
    public float beat; // テンポ変化が起きるbeat
    public float tempo; //　変化後のBPM

    public TempoChange(float beat, float tempo)
    {
        this.beat = beat;
        this.tempo = tempo;
    }
}