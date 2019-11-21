# biber by default, biblatex probably works too
# Used for generating references section
# Just make sure you se the backend in design.tex
BIB = biber
#Change this to whatever your latex backend is
TEX = xelatex
default: 
	$(TEX) design.tex
	$(BIB) design
	$(TEX) design.tex
