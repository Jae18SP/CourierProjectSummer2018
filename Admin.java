import java.util.Vector;

public class Admin extends Employee {
	private Object _login_ID;
	private Object _login_Pass;
	public Vector<Ticket> _unnamed_Ticket_ = new Vector<Ticket>();
	public Vector<Reports> _unnamed_Reports_ = new Vector<Reports>();
	public Customers _unnamed_Customers_;

	public void Add_OrderTaker() {
		throw new UnsupportedOperationException();
	}

	public void Update_OrderTaker() {
		throw new UnsupportedOperationException();
	}

	public void Add_Courier() {
		throw new UnsupportedOperationException();
	}

	public void Update_Courier() {
		throw new UnsupportedOperationException();
	}

	public void GenerateBillReport() {
		throw new UnsupportedOperationException();
	}

	public void GenerateBonusReport() {
		throw new UnsupportedOperationException();
	}

	public void GeneratePerformanceReport() {
		throw new UnsupportedOperationException();
	}
}