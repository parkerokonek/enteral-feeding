TEX=xelatex
BIB=biber
TFILE=req-draft.tex

cleanmake: clean build

build: 
	$(TEX) $(TFILE)

clean:
	rm ./*.pdf ./*.bcf ./*.aux ./*.run.xml -f
