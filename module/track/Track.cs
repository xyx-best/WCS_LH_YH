using enums.track;

namespace module.track
{
    public class Track
    {
        public uint id { set; get; }
        public string name { set; get; }
        public ushort area { set; get; }
        public byte type { set; get; }
        public byte stock_status { set; get; }//库存状态
        public byte track_status { set; get; }//轨道使用状态
        public ushort width { set; get; }
        public ushort left_distance { set; get; }
        public ushort right_distance { set; get; }
        public ushort ferry_up_code{set;get;}
        public ushort ferry_down_code{set;get;}
        public int max_store { set; get; }
        public uint brother_track_id { set; get; }
        public uint left_track_id { set; get; }
        public uint right_track_id { set; get; }
        public string memo { set; get; }
        public ushort rfid_1 { set; get; }
        public ushort rfid_2 { set; get; }
        public ushort rfid_3 { set; get; }
        public ushort rfid_4 { set; get; }
        public ushort rfid_5 { set; get; }
        public ushort rfid_6 { set; get; }
        public short order { set; get; }
        public uint recent_goodid { set; get; }
        public uint recent_tileid { set; get; }

        public TrackTypeE Type
        {
            get => (TrackTypeE)type;
            set => type = (byte)value;
        }

        public TrackStockStatusE StockStatus
        {
            get => (TrackStockStatusE)stock_status;
            set => stock_status = (byte)value;
        }

        public TrackStatusE TrackStatus
        {
            get => (TrackStatusE)track_status;
            set => track_status = (byte)value;
        }

        public bool IsInTrackTop(ushort rfid)
        {
            return rfid == rfid_1;
        }

        public bool IsInTrack(ushort rfid)
        {
            if (rfid == 0) return false;
            return rfid == rfid_1 || rfid == rfid_2 || rfid == rfid_3 || rfid == rfid_4 || rfid == rfid_5 || rfid == rfid_6;
        }

        public int TrackCode
        {
            get => ferry_down_code + ferry_up_code;
        }
    }
}
