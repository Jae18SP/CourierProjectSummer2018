import java.util.Vector;

public class Package {
	private String _packageID;
	private String _ticket_Number;
	private String _courierID;
	private String _courierNumber;
	private String _pickup_Intersection;
	private String _delivery_Intersection;
	public Courier _unnamed_Courier_;
	public Vector<Ticket> _unnamed_Ticket_ = new Vector<Ticket>();

	public void setPackageID(String aPackageID) {
		this._packageID = aPackageID;
	}

	public String getPackageID() {
		return this._packageID;
	}

	public void setTicket_Number(String aTicket_Number) {
		this._ticket_Number = aTicket_Number;
	}

	public String getTicket_Number() {
		return this._ticket_Number;
	}

	public void setCourierID(String aCourierID) {
		this._courierID = aCourierID;
	}

	public String getCourierID() {
		return this._courierID;
	}

	public void setCourierNumber(String aCourierNumber) {
		this._courierNumber = aCourierNumber;
	}

	public String getCourierNumber() {
		return this._courierNumber;
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
}