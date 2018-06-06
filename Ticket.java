import java.util.Vector;

public class Ticket {
	private String _ticket_Number;
	private String _package_ID;
	private String _pickup_Intersection;
	private String _delivery_Intersection;
	private int _pickup_Date;
	private int _pickup_Time;
	private int _delivery_Deadline_time;
	private int _delivery_Deadline_Date;
	public OrderTaker _unnamed_OrderTaker_;
	public Admin _unnamed_Admin_;
	public Package _unnamed_Package_;
	public Vector<Reports> _unnamed_Reports_ = new Vector<Reports>();

	public void Delivered_time() {
		throw new UnsupportedOperationException();
	}

	public void EstimateCostTime() {
		throw new UnsupportedOperationException();
	}

	public void Routing() {
		throw new UnsupportedOperationException();
	}

	public void setTicket_Number(String aTicket_Number) {
		this._ticket_Number = aTicket_Number;
	}

	public String getTicket_Number() {
		return this._ticket_Number;
	}

	public void setPackage_ID(String aPackage_ID) {
		this._package_ID = aPackage_ID;
	}

	public String getPackage_ID() {
		return this._package_ID;
	}

	public void setPickup_Intersection(String aPickup_Intersection) {
		this._pickup_Intersection = aPickup_Intersection;
	}

	public String getPickup_Intersection() {
		return this._pickup_Intersection;
	}

	public void setDelivery_Intersection(String aDelivery_Intersection) {
		this._delivery_Intersection = aDelivery_Intersection;
	}

	public String getDelivery_Intersection() {
		return this._delivery_Intersection;
	}

	public void setPickup_Date(int aPickup_Date) {
		this._pickup_Date = aPickup_Date;
	}

	public int getPickup_Date() {
		return this._pickup_Date;
	}

	public void setPickup_Time(int aPickup_Time) {
		this._pickup_Time = aPickup_Time;
	}

	public int getPickup_Time() {
		return this._pickup_Time;
	}

	public void setDelivery_Deadline_time(int aDelivery_Deadline_time) {
		this._delivery_Deadline_time = aDelivery_Deadline_time;
	}

	public int getDelivery_Deadline_time() {
		return this._delivery_Deadline_time;
	}

	public void setDelivery_Deadline_Date(int aDelivery_Deadline_Date) {
		this._delivery_Deadline_Date = aDelivery_Deadline_Date;
	}

	public int getDelivery_Deadline_Date() {
		return this._delivery_Deadline_Date;
	}
}