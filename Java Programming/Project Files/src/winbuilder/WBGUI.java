package winbuilder;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.JLabel;
import java.awt.Font;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

import javax.swing.JTextField;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JRadioButton;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import javax.swing.ButtonGroup;
import javax.swing.DefaultListModel;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.ListSelectionModel;

public class WBGUI extends JFrame {

	private static Connection connection = null;
	private static Statement statement = null;
	private static ResultSet resultSet = null;

	private static final String MS_FILE = "./menu.accdb";
	private static final String DB_URL = "jdbc:ucanaccess://" + MS_FILE;
	private static final String JDBC_DRIVER = "net.ucanaccess.jdbc.UcanaccessDriver";

	private JPanel contentPane;
	private JLabel lblName;
	private JTextField txtName;
	private JRadioButton rdbtnTakeOut;
	private JRadioButton rdbtnDineIn;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private JList lstMenu;
	private JButton btnAdd;
	private JButton btnCheckOut;
	private JList lstOrder;

	static String[] pizzaNames = new String[6];
	static double[] pizzaPrices = new double[6];
	static ArrayList<Integer> orderIndex = new ArrayList<Integer>();

	DefaultListModel<String> orderModel = new DefaultListModel<>();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					WBGUI frame = new WBGUI();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	public void setupComponents() {

		initDB();
		readDB();

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 612, 377);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);

		lblName = new JLabel("Name:");
		lblName.setFont(new Font("Tahoma", Font.BOLD, 12));

		txtName = new JTextField();
		txtName.setFont(new Font("Tahoma", Font.BOLD, 12));
		txtName.setColumns(10);

		rdbtnTakeOut = new JRadioButton("Take Out");
		buttonGroup.add(rdbtnTakeOut);
		rdbtnTakeOut.setFont(new Font("Tahoma", Font.BOLD, 12));

		rdbtnDineIn = new JRadioButton("Dine In");
		buttonGroup.add(rdbtnDineIn);
		rdbtnDineIn.setFont(new Font("Tahoma", Font.BOLD, 12));

		DefaultListModel<String> pizzaModel = new DefaultListModel<String>();

		for (int i = 0; i < pizzaNames.length; i++) {
			pizzaModel.addElement(pizzaNames[i] + ": " + pizzaPrices[i]);

		}

		lstMenu = new JList(pizzaModel);
		lstMenu.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

		lstMenu.setFont(new Font("Tahoma", Font.BOLD, 12));

		btnAdd = new JButton("Add");

		btnAdd.setFont(new Font("Tahoma", Font.BOLD, 12));

		btnCheckOut = new JButton("Check Out");

		btnCheckOut.setFont(new Font("Tahoma", Font.BOLD, 12));

		lstOrder = new JList();
		lstOrder.setFont(new Font("Tahoma", Font.BOLD, 12));
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.TRAILING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addComponent(lstMenu, GroupLayout.PREFERRED_SIZE, 219, GroupLayout.PREFERRED_SIZE)
					.addPreferredGap(ComponentPlacement.RELATED, 122, Short.MAX_VALUE)
					.addComponent(btnAdd)
					.addGap(18)
					.addComponent(lstOrder, GroupLayout.PREFERRED_SIZE, 219, GroupLayout.PREFERRED_SIZE)
					.addGap(19))
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addComponent(lblName, GroupLayout.PREFERRED_SIZE, 45, GroupLayout.PREFERRED_SIZE)
							.addPreferredGap(ComponentPlacement.RELATED)
							.addComponent(txtName, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(rdbtnTakeOut, GroupLayout.PREFERRED_SIZE, 103, GroupLayout.PREFERRED_SIZE)
						.addComponent(rdbtnDineIn, GroupLayout.PREFERRED_SIZE, 103, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnCheckOut))
					.addContainerGap(361, Short.MAX_VALUE))
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addContainerGap()
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(lblName)
						.addComponent(txtName, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addComponent(rdbtnTakeOut)
					.addPreferredGap(ComponentPlacement.RELATED)
					.addComponent(rdbtnDineIn)
					.addPreferredGap(ComponentPlacement.UNRELATED)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
						.addComponent(lstMenu, GroupLayout.PREFERRED_SIZE, 187, GroupLayout.PREFERRED_SIZE)
						.addComponent(lstOrder, GroupLayout.PREFERRED_SIZE, 186, GroupLayout.PREFERRED_SIZE)
						.addComponent(btnAdd))
					.addPreferredGap(ComponentPlacement.RELATED, 94, Short.MAX_VALUE)
					.addComponent(btnCheckOut)
					.addContainerGap())
		);
		contentPane.setLayout(gl_contentPane);

	}

	public void createEvents() {
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int toRemoved = -1;
				toRemoved = lstMenu.getSelectedIndex();

				if (toRemoved == -1) {
					JOptionPane.showMessageDialog(null, "Please choose items on the LHS.");
					return;
				}

				String picked = lstMenu.getSelectedValue().toString();
				orderModel.addElement(picked);
				lstOrder.setModel(orderModel);

				orderIndex.add(lstMenu.getSelectedIndex());
			}
		});

		btnCheckOut.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String name = txtName.getText();
				if (name.equals("")) {
					JOptionPane.showMessageDialog(null, "Please enter your name");
					return;
				}
				double totalCost = 0;
				for (int i = 0; i < orderIndex.size(); i++) {
					totalCost = (totalCost + pizzaPrices[orderIndex.get(i)]);
				}
				totalCost = totalCost + (totalCost * .05);
				String str = String.format("%.2f", totalCost);
				String orderType = "";
				if (rdbtnTakeOut.isSelected() || rdbtnDineIn.isSelected()) {
					if (rdbtnTakeOut.isSelected()) {
						orderType = "Take Out";
					} else if (rdbtnDineIn.isSelected()) {
						orderType = "Dine In";
					}
					JOptionPane.showMessageDialog(null, "Hi " + name + "!" + "\nYou ordered " + orderIndex.size()
							+ " item(s) for " + orderType + ". The total cost is " + str);
				} else {
					JOptionPane.showMessageDialog(null, "Please select Dine In or Take Out.");
				}

			}
		});
	}

	public static void initDB() {
		try {
			Class.forName(JDBC_DRIVER);
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		try {
			connection = DriverManager.getConnection(DB_URL);
			statement = connection.createStatement();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void readDB() {
		String sqlStr = "SELECT * FROM MENU";
		int i = 0;

		try {
			resultSet = statement.executeQuery(sqlStr);

			while (resultSet.next()) {
				int id = resultSet.getInt(1);
				String p = resultSet.getString("pizza");
				double r = resultSet.getDouble("price");
				Pizza menu = new Pizza(p, r);
				pizzaNames[i] = menu.getPizza();
				pizzaPrices[i] = menu.getPrice();
				i++;
			}

		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	/**
	 * Create the frame.
	 */
	public WBGUI() {
		setupComponents();
		createEvents();
	}
}
