/*
 * 様々な種類のノーツを表現するクラス。
 * ロングノーツには始点と終点がある。
 * シングルノーツには降ってくるタイミングとレーンを指定する
 */
public class NoteProperty
{
    public float beatBegin; // 始点が判定ラインと重なるbeat
    public float beatEnd; // 終点が判定ラインと重なるbeat
    public int lane; // レーン
    public NoteType noteType; // ノーツ種別
    
    public NoteProperty(float beatBegin, float beatEnd, int lange, NoteType noteType)
    {
        this.beatBegin = beatBegin;
        this.beatEnd = beatEnd;
        this.lane = lane;
        this.noteType = noteType;
    }
}

public enum NoteType
{
    Single, // シングルノーツ
    Long // ロングノーツ
}