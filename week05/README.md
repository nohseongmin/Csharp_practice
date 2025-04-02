# forms 이미지
![image](https://github.com/user-attachments/assets/1e6dcf97-3466-464e-817c-05aff800520e)

# form1.cs
```csusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04HomeWork
{
    public partial class FormManager : Form
    {
        //인스턴수 필드(변수) = 멤버 변수
        Department[] departments;
        List<Professor> professors;
        //생성자 = 인스턴스 생성시 초기화가 필요한 코드 삽입
        public FormManager()
        {
            //처음 한번만
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();
        }

        
        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1; //0에 넣어버리면 departments[0]이 비어있는지 확인불가
            for (int i=0; i<departments.Length; i++){
                if (departments[i] == null){
                    if (index < 0){
                        index=i;
                    }
                    index = i; //그래서 이걸로 예외처리
                    //break; break를 안쓰게되면 뒤부터 채워버림 
                }else{
                    if (departments[i].Code == tbxDepartmentCode.Text) {
                        MessageBox.Show("중복");
                        return;
                    }
                }
            }
            if (index < 0){
                MessageBox.Show("풀방");
                return;
            }
            Department dept = new Department(); //생성자는 특수 메소드기 때문에 () 필수
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}"); 
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if(lbxDepartment.SelectedIndex < 0)//선택 안된값은 -1
            {
                MessageBox.Show("선택안됨");
                return;
            }
            //is 연산자(t or f) 타입 확인용
            if(lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;
                for (int i=0; i<departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }
                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
                lbxDepartment.SelectedIndex = -1; //선택해제
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabMain.SelectedIndex){
                case 0: break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if(department != null) { 
                        cmbProfessorDepartment.Items.Add(department);
                        }
                    }
                    //선택초기화
                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2: break;
                default: break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정
            lbxProfessor.Items.Clear();
            //as는 형변환 but 실패해면 null 반환
            var department = cmbProfessorDepartment.SelectedItem as Department;
            if(department != null)
            {
                foreach(var professor in professors)
                {
                    //professor의 학과코드와 department의 코드가 같으면 보여주기
                    //null검사는 always.
                    if(professor != null && professor.DepartmentCode == department.Code)
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }
    }
}

```
