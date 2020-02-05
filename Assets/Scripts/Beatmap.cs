using System.Collections.Generic;
using System.Linq;

public class Beatmap
{
    public List<NoteProperty> NoteProperties = new List<NoteProperty>();
    public List<TempoChange> TempoChanges = new List<TempoChange>();
    
    // 指定されたテンポで、beatをsecに変換する
    public static float ToSecWithFixedTempo(float beat, float tempo)
    {
        return beat / (tempo / 60f);
    }
    // テンポ変化情報を基に、beatをsecへ変換する
    public static float ToSec(float beat, List<TempoChange> tempoChanges)
    {
        float accumulatedSec = 0f; // accumukatedSec: 累計の秒数
        int i = 0; // i: テンポ変化番号
        var n = tempoChanges.Count(x => x.beat <= beat); // n: 変換するbeat直前までのテンポ変化の回数
        
    }
}