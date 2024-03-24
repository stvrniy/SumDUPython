from fpdf import FPDF

class ResumeGenerator:
    def __init__(self):
        self.pdf = FPDF()

    def add_page(self):
        self.pdf.add_page()

    def add_personal_info(self, name, contact_info):
        self.pdf.set_font("Arial", size=12)
        self.pdf.cell(0, 10, f"Name: {name}", ln=True)
        self.pdf.cell(0, 10, f"Contact: {contact_info}", ln=True)
        self.pdf.ln(10)

    def add_education(self, degree, institution, graduation_year):
        self.pdf.set_font("Arial", size=12)
        self.pdf.cell(0, 10, "Education:", ln=True)
        self.pdf.cell(0, 10, f"Degree: {degree}", ln=True)
        self.pdf.cell(0, 10, f"Institution: {institution}", ln=True)
        self.pdf.cell(0, 10, f"Graduation Year: {graduation_year}", ln=True)
        self.pdf.ln(10)

    def add_experience(self, position, company, duration):
        self.pdf.set_font("Arial", size=12)
        self.pdf.cell(0, 10, "Experience:", ln=True)
        self.pdf.cell(0, 10, f"Position: {position}", ln=True)
        self.pdf.cell(0, 10, f"Company: {company}", ln=True)
        self.pdf.cell(0, 10, f"Duration: {duration}", ln=True)
        self.pdf.ln(10)

    def generate_pdf(self, filename):
        self.pdf.output(filename)

# Приклад використання
resume_generator = ResumeGenerator()
resume_generator.add_page()  # Додати нову сторінку
resume_generator.add_personal_info("John Doe", "john.doe@email.com")
resume_generator.add_education("Bachelor's in Computer Science", "XYZ University", "2020")
resume_generator.add_experience("Software Developer", "ABC Inc.", "2 years")
resume_generator.generate_pdf("resume.pdf")
