import java.util.Vector;

public class Reports {
	private String _estimatedDeliveryTime;
	private String _deliveredTime;
	public Admin _unnamed_Admin_;
	public Vector<Ticket> _unnamed_Ticket_ = new Vector<Ticket>();

	public void GenerateBillReport() {
		throw new UnsupportedOperationException();
	}

	public void GenerateBonusReport() {
		throw new UnsupportedOperationException();
	}

	public void GeneratePerformanceReport() {
		throw new UnsupportedOperationException();
	}

	public void setDeliveredTime(String aDeliveredTime) {
		this._deliveredTime = aDeliveredTime;
	}

	public String getDeliveredTime() {
		return this._deliveredTime;
	}
}