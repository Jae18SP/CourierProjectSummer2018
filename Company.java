import java.util.Vector;

public class Company {
	private String _name;
	private String _location;
	public Vector<Employee> _unnamed_Employee_ = new Vector<Employee>();

	public void setName(String aName) {
		this._name = aName;
	}

	public String getName() {
		return this._name;
	}
}