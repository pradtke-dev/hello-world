describe('todo', () => {
  it('should open the todo page', () => {
    cy.visit('http://localhost')
    cy.get('[data-cy=todo]').click()
  })
})